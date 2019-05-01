'use strict';
const mongoose = require('mongoose');
const _ = require('lodash');
const Product = mongoose.model('Product');

exports.get = (req, res, next) => {
    return Product
        .find({}, 'nome preco')
}

exports.getById = (id) => {
    return Product
        .findById(id)
}

exports.post = (objProduct) => {
    var product = new Product(objProduct);
    return product
        .save();
}

exports.put = (id, objProduct) => {
    return Product
        .findByIdAndUpdate(id, {
            $set: {
                nome: objProduct.nome,
                preco: objProduct.preco
            }
        })
}

exports.delete = (id) => {
    return Product
        .findOneAndRemove(id);
}