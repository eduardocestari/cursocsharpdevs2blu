function addItem() {
    // Pegando os valores dos campos name e qtd
    const name = $('input[name=name]').val();
    const comentario = $('input[name=comentario]').val();

    // Criando objeto com dados dos inputs
    const dataObj = { name, comentario };

    /* 
    Todo valor do localstorage é null no inicio (antes de adicionarmos algum valor nele),
    Por isso checamos se é null, ou seja, se será o primeiro item a ser adicionado.
    */
    if (localStorage.getItem('items') === null) {
      // Adicionando um array com um objeto no localstorage
      localStorage.setItem('items', JSON.stringify([dataObj]));
    } else {
      // Copiando o array existente no localstorage e adicionando o novo objeto ao final.
      localStorage.setItem(
        'items',
        // O JSON.parse transforma a string em JSON novamente, o inverso do JSON.strigify
        JSON.stringify([
          ...JSON.parse(localStorage.getItem('items')),
          dataObj
        ])
      );
    }
    
    renderItem(dataObj);
  }

  function renderItem(item) {
    // Adicionando uma div com o item e a quantidade na div .items
    $('.items').append(`
    <div class="list-group-item">
      <strong>${item.name}</strong>: ${item.comentario}
    </div>`);
  }

  function getItems() {
    // Pegando o array do localstorage
    const items = JSON.parse(localStorage.getItem('items'));

    // Para cada item do array, é renderizado no html
    items.forEach(item => renderItem(item));
  }

  getItems();