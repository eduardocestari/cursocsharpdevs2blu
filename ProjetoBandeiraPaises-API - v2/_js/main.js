
var btn = document.getElementById("btnbuscar");
var btn2 = document.getElementById("btnbuscar2");
var btn3 = document.getElementById("btnbuscar3");
var btn4 = document.getElementById("btnbuscar4");
var btn5 = document.getElementById("btnbuscar5");
var btn6 = document.getElementById("btnbuscar6");
let urlbusca = null;

btn.onclick = function() {

    let nome = $('#pesquisar').val();
    //console.log(nome);
    if (nome != ''){
        urlbusca = URL_BUSCA+nome;    
    }
    else{
        urlbusca =  URL_API_CHARACTER;  
    }
    //console.log(urlbusca);
    getAPI(urlbusca, criaListaCharacter);  
}

btn2.onclick = function() {
    getAPI(URL_EUROPA, criaListaCharacter);  
}

btn3.onclick = function() {
    getAPI(URL_AFRICA, criaListaCharacter);  
}

btn4.onclick = function() {
    getAPI(URL_AMERICAS, criaListaCharacter); 
}

btn5.onclick = function() {

    getAPI(URL_ASIA, criaListaCharacter); 
}

btn6.onclick = function() {
    getAPI(URL_OCEANIA, criaListaCharacter);  
}

addEventListener('load', function(){
    //getAPI(URL_API_CHARACTER, criaListaCharacter);
    
});

var listCharacter = new Array();

const criaListaCharacter = (data) => {
   
    //let main = getElement('main');
    //console.log(data);

    let results = document.getElementById("retorno_main");
    results.innerHTML = "";
    
    //listCharacter = new Array();   
    
    data.forEach(itemcard => {
        let html = document.createElement('div');
        html.classList.add('card', 'col-3', 'my-4', 'bg-white', 'ms-8');
        html.addEventListener('click', ()=> mostraDetalhesCharacter(itemcard))

        let htmlBody = `
        <div class="card-header" >
            <img class="card-img-top " src="${itemcard.flags.png}" alt="${itemcard.translations.pt}">
        </div>
        <div class="card-body bg-white">
            <h2 class="text-primary text-center" >${itemcard.translations.pt}</h2>
        </div>`;
        html.innerHTML = htmlBody;
        results.appendChild(html);
        //listCharacter.push(itemcard);   
    });

}

const mostraDetalhesCharacter = (itemcard) => {
    console.log(itemcard);
    let div = document.createElement('div');
    getElement('#modal-body').innerHTML = "";
    div.classList.add('card', 'col-12', 'my-4', 'bg-white');

    let cardBody = `
            <div class="modal-header">    
            <h1  class="text-primary text-center" id="charModalLabel">Bandeira  ${itemcard.translations.pt}</h1>
            </div>
            <div class="card-header">
                
                <img class="card-img-top" src="${itemcard.flag}" alt="Pais">
            </div>
            <div class="card-body bg-white">
                <h2 class="text-muted text-center">Principais Informações</h2>
                <p></´p>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item">Capital: ${itemcard.capital}</li>
                        <li class="list-group-item">Região: ${itemcard.region}</li>
                        <li class="list-group-item">Sub-Região: ${itemcard.subregion}</li>
                        <li class="list-group-item">População: ${itemcard.population}</li>
                        <li class="list-group-item">Time Zone: ${itemcard.timezones}</li>
                    </ul>
                </article>
            </div>
            <div class="modal-footer">
            <button
              type="button"
              class="btn btn-secondary"
              data-bs-dismiss="modal"
            >
              Close
            </button>
          </div>
        `;
        div.innerHTML = cardBody;
        getElement('#modal-body').appendChild(div);
        $('#charModal').modal('show');
}

$(document).ready(()=>{

    $('#btn_contato').click((e)=>{
        $('#favoritos').hide();
        $('#comentarios').hide();
        $('#comentario_form').hide();
        //$('#news').hide();
        results = document.getElementById("retorno_main");
        results.innerHTML = "";
        $.ajax({
            url: 'contato.html',
            dataType: 'html',
            success: (data) =>{
                $('#contato_form').html(data);
            }
        });
    });

    carrega_pag_comentario();
});

function carrega_pag_comentario() {
    //$('#news').hide();
    results = document.getElementById("comentario_form");
    results.innerHTML = "";
    $.ajax({
        url: 'comentario.html',
        dataType: 'html',
        success: (data) =>{
            $('#comentario_form').html(data);
        }
    });
}


function msg_newsletter() {
    alert("Obrigado, agora você irá ficar por dentro de todas as novidades!");
  };

  var news = [];
 
  function addNews(){

    if(document.getElementById("new_email").value == ""){
        alert('Por favor, preencha o seu e-mail!');
        document.getElementById("new_email").focus();
    } else {

     if (localStorage.newsArray){             
        news = JSON.parse(localStorage.getItem('newsArray')); 
        
     }
     
     let novoItem = document.getElementById("new_email").value;
     news.push(novoItem);
     document.getElementById("new_email").value = "";
     localStorage.newsArray = JSON.stringify(news); 
     msg_newsletter();
    }
  }


  btnmodalteste.onclick = function() {
    
    let resultDIV = document.getElementById('modal-body-news');
    resultDIV.innerHTML = "";
    if (localStorage.newsArray){             
        news = JSON.parse(localStorage.getItem('newsArray')); 
    }
    
    for(var i in news){
       let p = document.createElement("p");
       p.innerHTML = news[i];
       resultDIV.append(p);
    }

    $('#myModalNews').modal('show');
}



