Rails.application.routes.draw do
  namespace :api do
    namespace :v1 do
      resources :products
      resources :categories
    end
  end
  post '*path', to: 'application#not_found', as: 'not_found_any_post'
  post '/', to: 'application#not_found', as: 'not_found_home_post'
  get '*path', to: 'application#not_found', as: 'not_found_any_get'
  get '/', to: 'application#not_found', as: 'not_found_home_get'
end
