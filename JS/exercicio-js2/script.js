$(function(){
    //Corpo da função
    //Todo conteúdo deve ficar aqui
});

$("#content div:nth-child(1)").show();
$(".abas li:first div").addClass("selecionada");

$(".aba").hover(
    function(){$(this).addClass("ativa")},
    function(){$(this).removeClass("ativa")}
);

$(".aba").click(function(){
    $(".aba").removeClass("selecionada");
    $(this).addClass("selecionada");
    var indice = $(this).parent().index();
    indice++;
    $("#content div").hide();
    $("#content div:nth-child("+indice+")").show();
});