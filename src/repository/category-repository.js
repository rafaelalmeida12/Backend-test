'use strict';
const mongoose = require('mongoose');
const Category = mongoose.model('Category');

exports.get = (req, res, next) => {
    return Category
        .find({}, 'nome');
}

exports.getById = (id) => {
    return Category
        .findById(id);
}

exports.post = (objCategory) => {
    var category = new Category(objCategory);
    return category
        .save();
}

exports.put = (id, objCategory) => {
    return Category
        .findByIdAndUpdate(id, {
            $set: {
                nome: objCategory.nome,
                preco: objCategory.preco
            }
        }).setOptions({new: true})
}

exports.delete = (id) => {
    return Category
        .findOneAndRemove(id);
}