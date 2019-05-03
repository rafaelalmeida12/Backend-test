'use strict';

const repository = require('../repository/product-repository');

exports.get = (req, res, next) => {
    repository
    .get()
    .then(data => {
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
            res.status(200).send(data);
        })
        .catch(e => {
            res.status(400).send(e);
        })
}

exports.post = (req, res, next) => {
    repository
        .post(req.body)
        .then(x => {
            res.status(201).send({
                message: 'Produto cadastrado com sucesso!'
            });
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
        .then(x => {
            res.status(200).send({
                message: 'Produto atualizado com sucesso!'
            });
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