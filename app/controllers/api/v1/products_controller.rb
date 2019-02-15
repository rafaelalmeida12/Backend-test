module Api
  module V1
    class ProductsController < ApplicationController
      before_action :find_product, except: :create
      include CleanCharacters

      def create
        @product = Product.new(product_params.except(:category_ids))
        to_ar(params[:category_ids]).each {|category_id| insert_into_product(category_id)} if @product.save
        render status: :created, json: {cod: 201, status: "Created", message: {product: @product}} if @product.save
        render status: :bad_request, json: {cod: 400, status: "Bad Request", message: error_message(@product.errors)} unless @error || @product.save
      end

      def update; end

      def show; end

      def destroy; end

      def insert_into_product(id)
        category = Category.find(id) if Category.exists?(id)
        @error = false
        if category
          @product.categories << category
        else
          @product.destroy
          @error = true
          render status: :bad_request, json: {cod: 400, status: "Bad Request", message: "Categoria invalida ou não existe"} if @product.destroy
        end
      end

      private

      def find_product
        @product = Product.find(params[:id])
      end

      def product_params
        params.permit(:name, :price, :category_ids)
      end
    end
  end
end