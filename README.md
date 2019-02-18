# Backend-test Rovema

Rest API status codes

|   Cod   |   Status                  |                             Details                                            |
|:-------:|:-------------------------:|:------------------------------------------------------------------------------:|
|   200   |   OK                      |  means that your request and params is right to execute the program            |
|   201   |   Created                 |  means that your request and params is right to and created what you requested |
|   400   |   Bad Request             |  means that you did something wrong follow the "message" to fix it             |
|   404   |   Not Found               |  means the url that you're trying to request does not exist                    |
|   500   |   Internal Server Error   |  means the server is not ok, wait some minutes or call the developers          |


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

---

##### Update products

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

---

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

---

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

## Categories

##### Catching all categories

```
    GET /api/v1/categories
```

params

```
    no params
```

Example Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": {
        "categories": [
            {
                "id": 1,
                "name": "testando",
                "created_at": "2019-02-16T02:00:18.000Z",
                "updated_at": "2019-02-16T02:00:18.000Z"
            }
        ]
    }
}
```

##### Create category

```{json}
    POST /api/v1/categories
```

params

|   params     |    type    |     example      |
|:------------:|:----------:|:----------------:|
|   name       |   string   |     teste        |


Example Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": {
        "category": {
            "id": 2,
            "name": "teste",
            "created_at": "2019-02-16T02:02:08.000Z",
            "updated_at": "2019-02-16T02:02:08.000Z"
        }
    }
}
```

Example Error

```{json}
{
    "cod": 400,
    "status": "Bad Request",
    "message": [
        "name - já está em uso"
    ]
}
```

##### Update category

```
    PATCH /api/v1/categories/:id
            or
    PUT /api/v1/categories/:id
```

params

|   params     |    type    |     example      |
|:------------:|:----------:|:----------------:|
|   name       |   string   |     teste        |

Example Success

```{json}
{
    "cod": 200,
    "status": "OK",
    "message": {
        "category": {
            "id": 1,
            "name": "testying",
            "created_at": "2019-02-16T02:00:18.000Z",
            "updated_at": "2019-02-16T02:05:39.000Z"
        }
    }
}
```

Example Error

```{json}
{
    "cod": 400,
    "status": "Bad Request",
    "message": [
        "name - não pode ficar em branco"
    ]
}
```

##### Show Specific category

```
    GET /api/v1/categories/:id
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
        "category": {
            "id": 1,
            "name": "testying",
            "created_at": "2019-02-16T02:00:18.000Z",
            "updated_at": "2019-02-16T02:05:39.000Z"
        }
    }
}
```

Example Error

```{json}
{
    "cod": 404,
    "status": "Not Found",
    "message": "A categoria não foi encontrada"
}
```

##### Destroy category

```
    DELETE /api/v1/categories/:id
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
    "message": "Excluido com sucesso"
}
```

Example Error 

```{json}
{
    "cod": 404,
    "status": "Not Found",
    "message": "A categoria não foi encontrada"
}
```

## Docker

Execute docker compose running the command above on terminal

```
    sudo docker-compose up -d
```

Expected output

![docker compose](/storage/docker_compose_expected_output.png)

I configured a Dockerfile on hand and can be found in this [path](Dockerfile) you also can see with
details the docker compose configuration into [docker-compose.yml](docker-compose.yml)