'use strict';

exports.get = (req, res, next) => {
    res.status(200).send({
        title: "Rovema Backend Test",
        author: "Thiago Barbosa",
        version: "0.0.1"
    })
}