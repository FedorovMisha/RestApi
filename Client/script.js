const urlRes ='https://jsonplaceholder.typicode.com/todos/1'

const sendData = async(url,data) =>{
    const response = await fetch(url,
        {
            method:'POST',
            body: data,
        } );
       /* if (!response.ok ){
            throw new Error('Ошибка по адресу ${url}, статус ошибки ${response}');
        }
*/
        return await response.json()
}


const sendInfromation = () =>{

       

       const cartForm =document.getElementById('card');

       cartForm.addEventListener('submit', e => {
           e.preventDefault();
           const formData = new FormData (cartForm)

           sendData('https://jsonplaceholder.typicode.com/posts', formData)
       });
}


sendInfromation();

