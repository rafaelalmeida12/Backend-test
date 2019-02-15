## Products

##### Catching all products

```
    GET /api/v1/products
```

params

```
    no need params
```

Example Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": [
        {
            "id": 2,
            "name": "teste",
            "price": 123.12,
            "created_at": "2019-02-15T23:10:53.000Z",
            "updated_at": "2019-02-15T23:10:53.000Z"
        }
    ]
}
```

---

##### Creating new products

```
    POST /api/v1/products
```

params

|   params     |    type    |     example      |
|:------------:|:----------:|:----------------:|
|   name       |   string   |     teste        |
|   price      |   float    |     123.12       |
| category_ids |   FK       |     [1,2]        |

Example Success

```{json}
{
    "cod": 201,
    "status": "Created",
    "message": {
        "product": {
            "id": 4,
            "name": "teste",
            "price": 123.12,
            "created_at": "2019-02-15T23:22:01.000Z",
            "updated_at": "2019-02-15T23:22:01.000Z"
        },
        "categories": [
            {
                "id": 1,
                "name": "top",
                "created_at": "2019-02-15T22:30:11.000Z",
                "updated_at": "2019-02-15T22:30:11.000Z"
            }
        ]
    }
}
```

Example Error

```{json}
{
    "cod": 400,
    "status": "Bad Request",
    "message": [
        "name - não pode ficar em branco",
        "price - não pode ficar em branco"
    ]
}
```

##### Editing products

```
    PATCH  /api/v1/products/:id
                or
    PUT  /api/v1/products/:id
```

params

|   params     |    type    |     example      |
|:------------:|:----------:|:----------------:|
|   name       |   string   |     teste        |
|   price      |   float    |     123.12       |
| category_ids |   FK       |     [1,2]        |

Exampe Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": {
        "product": {
            "id": 2,
            "name": "testando",
            "price": 2456,
            "created_at": "2019-02-15T23:10:53.000Z",
            "updated_at": "2019-02-15T23:30:13.000Z"
        },
        "categories": [
            {
                "id": 1,
                "name": "top",
                "created_at": "2019-02-15T22:30:11.000Z",
                "updated_at": "2019-02-15T22:30:11.000Z"
            }
        ]
    }
}
```

Example Error

```{json}
{
    "cod": 400,
    "status": "Bad Request",
    "message": "Categoria invalida ou não existe"
}
```

##### Show Specific product

```
    GET /api/v1/products/:id
```

params

```
    no need params
```

Example Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": {
        "product": {
            "id": 4,
            "name": "teste",
            "price": 123.12,
            "created_at": "2019-02-15T23:22:01.000Z",
            "updated_at": "2019-02-15T23:22:01.000Z"
        },
        "categories": [
            {
                "id": 1,
                "name": "top",
                "created_at": "2019-02-15T22:30:11.000Z",
                "updated_at": "2019-02-15T22:30:11.000Z"
            }
        ]
    }
}
```

Example Error

```{json}
{
    "cod": 404,
    "status": "Not Found",
    "message": "O produto não foi encontrado"
}
```

##### Destroying product

```
    DELETE /api/v1/products/:id
```

params

```
    no need params
```

Example Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": "Excluído com sucesso"
}
```

Example Error

```{json}
{
    "cod": 404,
    "status": "Not Found",
    "message": "O produto não foi encontrado"
}
```