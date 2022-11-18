/* # Confs */
//const URL_API_CHARACTER = 'https://rickandmortyapi.com/api/character'
const URL_API_CHARACTER = 'https://restcountries.com/v2/all'
const URL_BUSCA = 'https://restcountries.com/v2/name/';
const URL_EUROPA = 'https://restcountries.com/v2/region/europe/';
const URL_AFRICA = 'https://restcountries.com/v2/region/africa/';
const URL_AMERICAS = 'https://restcountries.com/v2/region/americas/';
const URL_ASIA = 'https://restcountries.com/v2/region/asia/';
const URL_OCEANIA = 'https://restcountries.com/v2/region/Oceania/';

//https://restcountries.com/v2/name/Brazil

/* # Functions */
function getElement(q) {
    return document.querySelector(q);
}

const getAPI = (url, functionCallback) => {
    fetch(url).then(
        (response) => response.json(), // resolve (retorno OK)
        (error) => console.error(error) // reject (erro no retorno)
        ).then(
            dataJson => functionCallback(dataJson), // resolve (retorno OK)
            erro => console.error(erro) // reject (erro no retorno)
            ); 
}


