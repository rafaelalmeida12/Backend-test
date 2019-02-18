require 'test_helper'
module Api
  module V1
    class ProductsControllerTest < ActionDispatch::IntegrationTest
      setup do
        @teste_1 = products(:one)
        @teste_2 = products(:two)
        @category = categories(:one)
      end

      test 'show all products' do
        puts 'show all products'
        get(api_v1_products_path)
        assert_response :ok
      end

      test 'show one products' do
        puts 'show one products'
        get(api_v1_categories_path(@teste_1.id))
        assert_response :ok
      end

      test 'create a products' do
        puts 'create a products'
        category_params = {name: Faker::Coffee.blend_name, price: 25.22, categories: "[#{@category.id}]"}
        post('/api/v1/products', params: category_params)
        assert_response :created
      end

      test 'update a products' do
        puts 'updating a products'
        put("/api/v1/products/#{@teste_1.id}", params: {name: Faker::Coffee.blend_name})
        assert_response :ok
      end

      test 'destroying a product' do
        puts 'destroying a product'
        delete("/api/v1/products/#{@teste_2.id}")
        assert_response :ok
      end

      test 'invalid params on create product' do
        puts 'invalid params on create product'
        category_params = {name: ""}
        post('/api/v1/products', params: category_params)
        assert_response :bad_request
      end

      test 'not found a product' do
        puts 'not found  a product'
        delete("/api/v1/products/6")
        assert_response :not_found
      end
    end
  end
end