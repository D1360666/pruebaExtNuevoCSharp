var options = {
    enableHighAccuracy: true,
    timeout: 5000,
    maximumAge: 0
};
var latitud, longitud;

function success(pos) {
    var crd = pos.coords;

    console.log('Your current position is:');
    console.log(`Latitude : ${crd.latitude}`);
    console.log(`Longitude: ${crd.longitude}`);
    console.log(`More or less ${crd.accuracy} meters.`);
    latitud = crd.latitude;
    longitud = crd.longitude;
}

function error(err) {
    console.warn(`ERROR(${err.code}): ${err.message}`);
}
navigator.geolocation.getCurrentPosition(success, error, options);

var raster = new TileLayer({
    source: new OSM()
});

var source = new VectorSource({ wrapX: false });

var vector = new VectorLayer({
    source: source.coords(latitud, longitud);
});

var map = new Map({
    layers: [raster, vector],
    target: 'map',
    view: new View({
        center: [latitud, longitud],
        zoom: 4
    })
});
