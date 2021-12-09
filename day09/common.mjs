prepareCanvas = (map, canvas, width) => {
    const size = width / map[0].length;
    canvas.width = width;
    canvas.height = size * map.length;

    var ctx = canvas.getContext("2d");
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    return size;
}

drawMap = (map, canvas, size) => {
    var ctx = canvas.getContext("2d");

    for (var j = 0; j < map.length; j++) {
        for (var i = 0; i < map[0].length; i++) {
            ctx.fillStyle = "rgba(0,256,0, " + (map[j][i] / 20 + 0.5) +")";
            ctx.fillRect(size * i, size * j, size, size);
        }
    }
}

drawPoints = (points, color, canvas, size) => {
    var ctx = canvas.getContext("2d");
    for (var {Item1, Item2} of points) {
        ctx.fillStyle = color;
        ctx.fillRect(size * Item2, size * Item1, size, size);
    }
}