module Api
  module V1
    class ProductsController < ApplicationController
      before_action :find_product, execpt: :create

      def create
        @product = Product.new(product_params)
        render :ok, json: {cod: 200, status: "success", message: {product: @product}} if @product
      end

      def update; end
      def show; end
      def destroy; end

      private

      def find_product
        @product = product.find(params[:id])
      end

      def product_params
        parama(:product).premit(:name, :price)
      end
    end
  end
end