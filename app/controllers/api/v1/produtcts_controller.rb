module Api
  module V1
    class ProductsController < ApplicationController
      before_action :find_product, execpt: :create

      def create; end
      def update; end
      def show; end
      def destroy; end

      private

      def find_product
        @product = product.find(params[:id])
      end

      def product_params; end

    end
  end
end