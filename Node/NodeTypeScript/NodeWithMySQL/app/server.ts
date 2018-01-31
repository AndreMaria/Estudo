import * as express from 'express';
var load = require('express-load');

const app: express.Application = express()
const port: number = process.env.PORT || 3000;

var user = require('./routes/userRoutes')
app.use('/user',user)

load('models').then('controllers').then('routes').into(app)

app.listen(port,()=> { console.log(`Listening at http://localhost:${port}/`)})
