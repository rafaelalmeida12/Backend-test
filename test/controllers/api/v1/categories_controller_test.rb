require 'test_helper'
module Api
  module V1
    class CategoriesControllerTest < ActionDispatch::IntegrationTest
      setup do
        @teste_1 = categories(:one)
        @teste_2 = categories(:two)
      end

      test 'show all categories' do
        puts 'show all categories'
        get(api_v1_categories_path)
        assert_response :ok
      end

      test 'show one category' do
        puts 'show one category'
        get(api_v1_categories_path(@teste_1.id))
        assert_response :ok
      end

      test 'create a category' do
        puts 'create a category'
        category_params = {name: Faker::Coffee.blend_name}
        post('/api/v1/categories', params: category_params)
        assert_response :created
      end

      test 'update a category' do
        puts 'updating a category'
        put("/api/v1/categories/#{@teste_1.id}", params: {name: Faker::Coffee.blend_name})
        assert_response :ok
      end

      test 'destroying a category' do
        puts 'destroying a category'
        delete("/api/v1/categories/#{@teste_2.id}")
        assert_response :ok
      end

      test 'invalid params on create category' do
        puts 'invalid params on create category'
        category_params = {name: ""}
        post('/api/v1/categories', params: category_params)
        assert_response :bad_request
      end

      test 'not found a category' do
        puts 'not found  a category'
        delete("/api/v1/categories/6")
        assert_response :not_found
      end
    end
  end
end