class CreateJoinTableProductsCategories < ActiveRecord::Migration[5.2]
  def change
    create_join_table :products, :categories do |t|
      t.index [:product_id, :category_id]
      t.index [:category_id, :product_id]
    end

    change_column :categories_products, :category_id, :integer, limit: 4
    change_column :products, :id, :integer, limit: 4

    add_foreign_key :categories_products, :products, column: :category_id, primary_key: :id
    add_foreign_key :categories_products, :categories, column: :product_id, primary_key: :id
  end
end
