module CleanCharacters
  def error_message(array_message)
    error_message = []
    array_message.each {|message| error_message << "#{message} - #{array_message[message][0]}"}
    error_message
  end

  def to_ar(string)
    array = string.gsub(" ", "").tr('[]', '').split(',').map(&:to_s)
    array
  end

  def routes
    routes = {
        "GET /api/v1/products": "Here you can see all products",
        "POST /api/v1/products": "Here you can create a new product",
        "GET /api/v1/products/:id": "Here you can see product with details",
        "PATCH or PUT /api/v1/products/:id": "Here you can update a existent product",
        "DELETE /api/v1/products/:id": "Here you can delete a product",
        "GET /api/v1/categories": "Here you can see all categories",
        "POST /api/v1/categories": "Here you can create a new category",
        "GET /api/v1/categories/:id": "Here you can see category with details",
        "PATCH or PUT /api/v1/categories/:id": "Here you can update a existent category",
        "DELETE /api/v1/categories/:id": "Here you can delete a category",
    }
    routes
  end
end