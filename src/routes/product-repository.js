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