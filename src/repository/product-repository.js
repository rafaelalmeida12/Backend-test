'use strict';
const mongoose = require('mongoose');
const _ = require('lodash');
const Product = mongoose.model('Product');

exports.get = (req, res, next) => {
    return Product
        .find({}, 'nome preco categorias')
        .populate('categorias');
}

exports.getById = (id) => {
    return Product
        .findById(id)
        .populate('categorias');
}

exports.getByCategory = (id) => {
    return Product
        .find({categorias: id})
        .populate('categorias');
}

exports.post = (objProduct) => {    
    var product = new Product(objProduct);
    product.categorias = _.uniqWith(objProduct.categorias, _.isEqual);
    return product
        .save();
}

exports.put = (id, objProduct) => {
    return Product
        .findByIdAndUpdate(id, {
            $set: {
                nome: objProduct.nome,
                preco: objProduct.preco,
                categorias: _.uniqWith(objProduct.categorias, _.isEqual)
            }
        }).setOptions({new: true})
}

exports.delete = (id) => {
    return Product
        .findByIdAndDelete(id);
}
