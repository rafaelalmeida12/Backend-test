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
            res.status(200).send(data);
        })
        .catch(e => {
            res.status(400).send(e);
        });
}

exports.post = (req, res, next) => {
    repository
        .post(req.body)
        .then(x => {
            res.status(201).send({
                message: 'Categoria cadastrado com sucesso!'
            });
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
        .then(x => {
            res.status(200).send({
                message: 'Categoria atualizado com sucesso!'
            });
        })
        .catch(e => {
            res.status(400).send({
                message: 'Falha ao atualizar a categoria',
                data: e
            });
        });
}
