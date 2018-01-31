
import * as express from 'express';

const app: express.Application = express();
const port: number = process.env.PORT || 3000;
con

app.listen(port, ()=> { console.log(`Listening at http://localhost:${port}/`)});
