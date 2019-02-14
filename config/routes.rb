Rails.application.routes.draw do
  namespace :api do
    namespace :v1 do
      resources :products, except: :index
      resources :categories, except: :index
    end
  end
end
