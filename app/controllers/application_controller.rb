class ApplicationController < ActionController::API
  include CleanCharacters
  
  def not_found
    render status: :not_found, json: {cod: 404, status: "not_found", message: {error: "Essa rota não existe, cheque nossa lista de rotas abaixo", routes: routes}}
  end
end
