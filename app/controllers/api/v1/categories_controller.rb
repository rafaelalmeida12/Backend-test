module Api
  module V1
    class CategoriesController < ApplicationController
      before_action :set_category, except: [:create, :index]
      include CleanCharacters

      def index
        render json: {cod: 200, status: "OK", message: {categories: Category.all}}
      end

      def create
        @category = Category.new(category_params)
        render status: :created, json: {cod: 201, status: "created", message: {category: @category}} if @category.save
        render status: :bad_request, json: {cod: 400, status: "Bad Request", message: error_message(@category.errors)} unless @category.save
      end

      def update
        render json: {cod: 200, status: "OK", message: {category: @category}} if @category.update(category_params)
        render status: :bad_request, json: {cod: 400, status: "Bad Request", message: error_message(@category.errors)} unless @category.update(category_params)
      end

      def show
        render json: {cod: 200, status: "OK", message: {category: @category}} if @category
      end

      def destroy
        render json: {cod: 200, status: "OK", message: "Excluido com sucesso"} if @category.destroy
      end

      private

      def set_category
        @category = Category.find(params[:id]) if Category.exists?(params[:id])
        render status: :not_found, json: {cod: 404, status: "Not Found", message: "A categoria não foi encontrada"} unless Category.exists?(params[:id])
      end

      def category_params
        params.permit(:name)
      end
    end
  end
end