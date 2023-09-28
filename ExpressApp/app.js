const express = require("express");
const http = require("http");
const api = express();
const data = require("./data.json");
const server = http.createServer(api);
const fs = require("fs");

const HOST = 'localhost'
const PORT = 1337


api.get('/', (req, res) => {
    res.send('Bienvenido a mi servicio de REST Api con Express JS')
})

api.get('/notas', (req, res) => {
    res.status(200).json(data)
})

api.post('/notas', (req, res) => {

    var notaParaGuardar = req.originalUrl.split('?')[1];
    var content = fs.readFileSync("./data.json");
    var jsonContent = JSON.parse(content);
    jsonContent.data.push(notaParaGuardar);
    var newData = '{"data":' + JSON.stringify(jsonContent.data) + '}'

    fs.writeFile("./data.json", newData, (err) => {
        if (err) throw err;
        console.log("nota guardada");
    });
})


api.delete('/notas', (req, res) => {

    fs.writeFile("./data.json", JSON.stringify({ "data": [] }), (err) => {
        if (err) throw err;
        console.log("notas borradas");
    });
})


server.listen(PORT, () => console.log(`API running at ${HOST}:${PORT}!`))
