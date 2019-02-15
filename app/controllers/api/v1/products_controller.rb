module Api
  module V1
    class ProductsController < ApplicationController
      before_action :find_product, except: :create
      include CleanCharacters

      def create
        @product = Product.new(product_params)
        render status: :created, json: {cod: 201, status: "Created", message: {product: @product}} if @product.save
        render status: :bad_request, json: {cod: 400, status: "Bad Request", message: error_message(@product.errors)} unless @product.save
      end

      def update; end
      def show; end
      def destroy; end

      private

      def find_product
        @product = Product.find(params[:id])
      end

      def product_params
        params.permit(:name, :price)
      end
    end
  end
end