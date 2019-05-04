'use strict';

const repository = require('../repository/category-repository');

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
                    "message": "Categoria não encontrada!"
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

exports.post = (req, res, next) => {
    repository
        .post(req.body)
        .then(data => {
            if (data != null) {
                res.status(201).send({
                    message: 'Categoria cadastrada com sucesso!',
                    categoria: data
                });
            }
            else {
                res.status(400).send({
                    message: 'Falha ao cadastrar a categoria'                    
                });
            }
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao cadastrar a categoria',
                data: e
            });
        });
};

exports.put = (req, res, next) => {
    repository
        .put(req.params.id, req.body)
        .then(data => {
            if (data != null) {
                res.status(200).send({
                    message: 'Categoria atualizada com sucesso!',
                    categoria: data
                });
            }
            else {
                res.status(404).send({
                    message: 'Categoria não encontrada!',                    
                });
            }
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao atualizar a categoria',
                data: e
            });
        });
}

exports.delete = (req, res, next) => {    
    repository
        .delete(req.body._id)
        .then(data => {
            console.log(data);
            if (data!= null) {
                res.status(200).send({
                    "message": "Categoria removida com sucesso!"
                })
            }
            else {
                res.status(400).send({
                    "message": "Ocorreu um erro ao remover a categoria!"
                })
            }
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao remover a categoria',
                data: e
            })
        })
}