module Api
  module V1
    class ProductsController < ApplicationController
      before_action :find_product, except: [:create, :index]
      include CleanCharacters

      def index
        render json: {cod: 200, status: "OK", message: Product.all}
      end

      def create
        @product = Product.new(product_params.except(:category_ids))
        to_ar(params[:category_ids]).each {|category_id| insert_into_product(category_id)} if @product.save
        render status: :created, json: {cod: 201, status: "Created", message: {product: @product, categories: @product.categories}} if @product.save
        render status: :bad_request, json: {cod: 400, status: "Bad Request", message: error_message(@product.errors)} unless @error || @product.save
      end

      def update
        if @product.update(product_params.except(:category_ids))
          to_ar(params[:category_ids]).each {|category_id| insert_into_product(category_id)}
          render json: {cod: 200, status: "OK", message: {product: @product, categories: @product.categories}}}
        else
          render status: :bad_request, json: {cod: 400, status: "Bad Request", message: error_message(@product.errors)} unless @error
        end
      end

      def show
        render json: {cod: 200, status: "OK", message: {product: @product, categories: @product.categories}}} if @product
      end

      def destroy
        @product.destroy if @product
        render json: {cod: 200, status: "OK", message: "Excluído com sucesso"} if @product.destroy
      end

      def insert_into_product(id)
        category = Category.find(id) if Category.exists?(id)
        @error = false
        if category
          @product.categories << category if @product.categories.find_by(name: category.name).blank?
        else
          @product.destroy
          @error = true
          render status: :bad_request, json: {cod: 400, status: "Bad Request", message: "Categoria invalida ou não existe"} if @product.destroy
        end
      end

      private

      def find_product
        @product = Product.find(params[:id]) if Product.exists?(params[:id])
        render status: :not_found, json: {cod: 404, status: "Not Found", message: "O produto não foi encontrado"} unless Product.exists?(params[:id])
      end

      def product_params
        params.permit(:name, :price, :category_ids)
      end
    end
  end
end