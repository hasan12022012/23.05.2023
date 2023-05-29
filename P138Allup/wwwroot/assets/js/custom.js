$(document).ready(function () {
    let page = window.location.pathname.split('/')[1];

    console.log(page.length)

    if (page.length == 0) {
        $('.Home').addClass('active');
    } else {
        $('.' + page).addClass('active')
    }

    $('.searchBtn').click(function (e) {
        e.preventDefault();

        let search = $('.searchInput').val();
        let categoryId = $('.categoriesList').val();

        fetch('product/search' + categoryId + '?search=' + search)
            .then(res => {
                return res.json();
            }).then(date => {
                let liItem = "";

                for (var i = 0; i < data.length; i++) {
                    let li = ` <li>
                                                <a href="#" class="d-flex justify-content-between align-items-center">
                                                    <img style="width:100px" src="/assets/images/product/${data[i].mainImage}"/>
                                                    <p>${data[i].title}</p>
                                                    <span class="price-sale">€${data[i].price}</span>
                                                </a>
                                            </li>`;
                    
                    liItem += li;
                }
                $('.searchList').html(liItem)
            })
        console.log(search + ' ' + categoryId);
    })
})
