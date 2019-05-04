'use strict';

const repository = require('../repository/product-repository');

exports.get = (req, res, next) => {
    repository
    .get()
    .then(data => {
        console.log(data)
        res.status(200).send(data);
    })
    .catch(e => {
        res.status(400).send(e);
    });
};

exports.getById = (req, res, next) => {
    repository
        .getById(req.params.id)
        .then(data => {
            if (data == null) {
                res.status(404).send({
                    "message": "Produto não encontrado!"
                })
            }
            else {
                res.status(200).send(data);            
            }
        })
        .catch(e => {
            res.status(400).send(e);
        });
}

exports.getByCategory = (req, res, next) => {
    repository
        .getByCategory(req.params.id)
        .then(data => {
            console.log(data);
            if (data.length <= 0) {
                res.status(404).send({
                    "message": "Nenhum produto encontrado!"
                })
            }
            else {
                res.status(200).send(data);            
            }
        })
        .catch(e => {
            res.status(400).send(e);
        })
}

exports.post = (req, res, next) => {
    repository
        .post(req.body)
        .then(data => {
            if (data!= null) {
                res.status(201).send({
                    "message": "Produto criado com sucesso!",
                    "Produto": data
                })
            }
            else {
                res.status(400).send({
                    "message": "Ocorreu um erro ao atualizar o produto!"
                })
            }
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao cadastrar o produto',
                data: e
            });
        });
};

exports.put = (req, res, next) => {
    repository
        .put(req.params.id, req.body)
        .then(data => {
            if (data!= null) {
                res.status(200).send({
                    "message": "Produto atualizado com sucesso!",
                    "Produto": data
                })
            }
            else {
                res.status(400).send({
                    "message": "Ocorreu um erro ao atualizar o produto!"
                })
            }
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao atualizar o produto',
                data: e
            });
        });
}

exports.delete = (req, res, next) => {
    repository
        .delete(req.body.id)
        .then(x => {
            res.status(200).send({
                message: 'Produto removido com sucesso!'
            });
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao cadastrar o produto',
                data: e
            })
        })
}