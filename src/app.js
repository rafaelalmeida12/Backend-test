'use strict';

const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');

const app = express();

mongoose.connect('mongodb+srv://thiago:0123654@nodestr-gau4c.azure.mongodb.net/backend-test?retryWrites=true');

const indexRoute = require('./routes/index-route');

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({
    extended: false
}))

app.use('/', indexRoute);

module.exports = app;