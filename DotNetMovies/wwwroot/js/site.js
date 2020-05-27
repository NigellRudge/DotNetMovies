var baseUrl = window.location.hostname;
var portNumber = ":44317";
var a = "https://";
baseUrl = baseUrl.replace(/\//g, "");
$(document).ready(function () {

    $(document).keypress(function (event) {

        $('#searchInput').focus();


    });

    $(document).keypress(function (event) {
        if (event.which === 27) {
            $('#searchInput').focusout();
        }
        console.log(event.hwi)

    });
});

function HelloWorld(event) {
    event.preventDefault();

    var query = event.target.value;
    if (query === null || query === "") {
        refresh();
        return;
    }
    let url = a + baseUrl + portNumber + "/movies/search?query=" + query;
    console.log(url);
    console.log(event.target.value);
    fetch(url)
        .then((response) => {
            EnableSpinnder();
            return response.json();
        })
        .then(data => {
            refresh();
            setTimeout(DisableSpinnder, 8000);

            if (data.length > 0 || data === null) {
                CreateList(data);
            }
            else {
                CreateEmpty(query);
            }

        });

}

function CreateElement(result) {

    if (result['poster_path'] === null || result['poster_path'] === "") {
        console.log(result['poster_path']);
        console.log(result['id']);
        result['poster_path'] = "/img/poster_placeholder.png";
    }
    else {
        result['poster_path'] = "https://image.tmdb.org/t/p/w200" + result['poster_path'];
    }
    return `<li class="border-b border-gray-700">
                            <a href="/movies/Details/${result['id']} "class="block hover:bg-gray-700 px-3 py-3 flex items-center transition ease-in-out duration-150" >
                                <img src="${result['poster_path']}" alt="poster" class="w-8">
                                <span class="ml-4">${result['title']}</span>
                             </a>
                        </li >`;
}

function CreateList(data) {
    var count = data.length > 5 ? 5 : data.length;
    console.log("count:" + count);
    for (var i = 0; i < count; i++) {
        $(CreateElement(data[i])).appendTo('#resultsList');
    }
}

function CreateEmpty(query) {
    $("#resultsList").append(
        `<div class="px-3 py-3">
                         No results for ${query}
                     </div>`
    );
}
function refresh() {
    $("#resultsList").empty();
    console.log('Empty');
}

function EnableSpinnder() {
    refresh();
    $("#resultsList").append(
        `<div class="px-3 py-3 loader"></div>`
    );
}
function DisableSpinnder() {
    $('.loader').remove();
}