'use strict';

const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');

const app = express();

mongoose
  .connect('mongodb+srv://thiago:0123654@nodestr-gau4c.azure.mongodb.net/backend-test?retryWrites=true')
  .then(() => console.log('MongoDB Connected'))
  .catch(err => console.log(err));

  // mongoose
  // .connect(
  //   'mongodb://mongo:27017/backend-test',
  //   { useNewUrlParser: true }
  // )
  // .then(() => console.log('MongoDB Connected'))
  // .catch(err => console.log(err));

const ProductModel = require('./models/product-model');
const CategoryModel = require('./models/category-model');

const indexRoute = require('./routes/index-route');
const productRoute = require('./routes/product-route');
const categoryRoute = require('./routes/category-route');

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({
    extended: false
}))

app.use('/', indexRoute);
app.use('/products', productRoute);
app.use('/categories', categoryRoute);

module.exports = app;