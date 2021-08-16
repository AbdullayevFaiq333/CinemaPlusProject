
// KontaktTV Start
let openedModal = document.querySelectorAll(".openedModal")
let fadeModal = document.querySelector(".fadeModal")
let closedBtn = document.querySelector(".closeBtn")
let modalBody = document.querySelectorAll(".modal-body")
let myButton=document.querySelector('.myButton')

let arr = ['<iframe width="700" height="400" src="https://www.youtube.com/embed/zbL5feqnIDY" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'
,'<iframe width="700" height="400" src="https://www.youtube.com/embed/BeeoU5vd5Jg" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'
,'<iframe width="700" height="400" src="https://www.youtube.com/embed/9DV8rYEwB94" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'
,'<iframe width="700" height="400" src="https://www.youtube.com/embed/-KxYqdXWgIw" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'
,'<iframe width="700" height="400" src="https://www.youtube.com/embed/-KxYqdXWgIw" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'
]

openedModal.forEach((modall, ind) => {
    modall.addEventListener("click", (e) => {
        document.querySelector(`.${modall.classList[0]} .modal-body`).innerHTML = ` ${arr[ind]}`
        
    })
})
//closeBtn
if (closedBtn) {
    closedBtn.addEventListener("click", () => {
        
        modalBody.forEach((elem, ind) => {
            elem.innerHTML = ''
        })
    })
}

//Swiper
let carouselVideo=document.querySelector('.carousel-video')
if (carouselVideo) {
    new Swiper('.carousel-video',{
        autoplay: {
            delay: 3000,
            stopOnLastSlide: true,
            disableOnInteraction: false,
        },
        watchOverflow: true,
        slidesPerView: 4,
        loop: true,
        
    })
}
// KontaktTV End

// Main Slider Start


let mainSlider=document.querySelector('.main-slider')
if (mainSlider) {
    const swiper = new Swiper('.main-slider', {
        // Navigation click
        
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev'
        },

        // Avtoplay intervar
        autoplay: {
            delay: 2000,
            stopOnLastSlide: true,
            disableOnInteraction: false,
        },
        speed: 500,
        loop: true,

    }); 
}

// Main Slider End

//Right Daily Slider Swiper Start
let dragCard = document.querySelector('.slider-price-drag-card')
if (dragCard) {
    const swiper = new Swiper('.slider-price-drag-card', {
        //navigation click


        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev'
        },
        //pagination
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
            dynamicBullets: true,
        },

        //Avtoplay intervar
        autoplay: {
            delay: 2000,
            stopOnLastSlide: true,
            disableOnInteraction: false,
        },
        speed: 500,
        loop: true,

    });
}
//Right Daily Slider Swiper End


//Carousel Products Start
let carouseldiv = document.querySelector('.carouseldiv')
if (carouseldiv) {
    new Swiper('.carouseldiv', {
        // pagination:{
        //     el: '.swiper-pagination',
        //     clickable:true,
        // },

        watchOverflow: true,

        autoplay: {
            delay: 1000,
            stopOnLastSlide: true,
            disableOnInteraction: false,
        },
        loop: true,
        speed: 800,
        breakpoints: {
            480: {
                slidesPerView: 2.3,
            },
            992: {
                slidesPerView: 3.5,
            },
            1200: {
                slidesPerView: 4.5,
            }
        }
    });
}

//Carousel Products End

// Carousel Partners  Start
let partnersmain = document.querySelector('.partners-main')
if (partnersmain) {
    new Swiper('.partners-main', {
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev'
        },
        watchOverflow: true,
        autoplay: {
            delay: 5000,
            stopOnLastSlide: true,
            disableOnInteraction: false,
        },
        loop: true,
        speed: 300,
        breakpoints: {
            480: {
                slidesPerView: 3,
            },
            992: {
                slidesPerView: 4,
            },
            1200: {
                slidesPerView: 8,
            }
        }

    });
}
//Sidebars Hover
// let sidebarsHover=document.querySelector('#sidebars .product-menu')
// if (sidebarsHover) {
//     sidebarsHover.addEventListener('mouseover',function () {
//         document.body.classList.toggle('menu-open')
//     })
// }
// Menu Burger Start
let menuIcon = document.querySelector('.section-menu .menu-icon')
if (menuIcon) {
    let sidebarSection = document.querySelector('.sidebar-section')
    menuIcon.addEventListener("click", function () {

        document.body.classList.toggle('menu-open')
        sidebarSection.classList.toggle('active')
        menuIcon.classList.toggle('active')

    })
}
//Accordion Start

let li=document.querySelectorAll('.accordion-menu li')
li.forEach(s=>{
    s.addEventListener('click',function() {
        this.classList.toggle('active')
        
        if (this.nextElementSibling.classList.contains('active')) {
            this.nextElementSibling.classList.remove('active')
        }
        else{
            this.nextElementSibling.classList.add('active')
        }
        
        
        
    })
})

//local storage
// let addCartBtns=document.querySelectorAll('.btn-add-to-cart')

// if (addCartBtns) {
//     addCartBtns.forEach(btn=>{
//         btn.addEventListener('click', function(){
//           let id=this.getAttribute('data-id')
//         })
//     })
// }

// Selections page button
let btnFeature=document.querySelector('#selections .btn-feature')

if (btnFeature) {
    let content=document.querySelector('#selections .content')
    btnFeature.addEventListener('click',function() {
        btnFeature.classList.toggle('active')
        content.classList.toggle('d-none')

    })
}

//Products page collapse
let collapsebtn=document.querySelector('.a-collapse')
let pageText=document.querySelector('#product-search .page-text')
let coxazspan=document.querySelector('#product-search .azspan')
let icon=document.querySelector('#product-search .fa-chevron-up')
if (collapsebtn) {
    collapsebtn.addEventListener('click',function () {
        pageText.classList.toggle('collapse-az')
        if (icon.classList.contains('d-none')) {
            icon.classList.remove('d-none')
            icon.previousElementSibling.classList.add('d-none')
            coxazspan.classList.remove('d-none')
            coxazspan.previousElementSibling.classList.add('d-none')
        }
        else{
            icon.classList.add('d-none')
            icon.previousElementSibling.classList.remove('d-none')
            coxazspan.classList.add('d-none')
            coxazspan.previousElementSibling.classList.remove('d-none')
        }
              
    })
}


//Products
let active=document.querySelector('.first-menu li')
if (active) {
    active.addEventListener('click',function () {
        if (active.classList.contains('active')) {
            active.classList.remove('active')
        }
        else{
            active.classList.add('active')
        }
        
    })
}
let activeBtn=document.querySelectorAll('.btn-feature')


if (activeBtn) {
    activeBtn.forEach(a=>{
        a.addEventListener('click', function () {
            if (a.classList.contains('active')) {
                a.classList.remove('active')
                a.nextElementSibling.classList.add('d-none')
            }
            else{
                a.classList.add('active')
                a.nextElementSibling.classList.remove('d-none')
                
            }
            
        })
    })
}


let clickView=document.querySelectorAll('#product-list .click-view')
if (clickView) {
    clickView.forEach(a=>{
        a.addEventListener('click',function () {
          if (a.firstElementChild.firstElementChild.classList.contains('sgvup')) {
            a.firstElementChild.firstElementChild.classList.remove('sgvup')
          }
          else{
            a.firstElementChild.firstElementChild.classList.add('sgvup')
          }
        })
    })
}

let clickNum=document.querySelectorAll('#product-list .click-num li')
if (clickNum) {
    clickNum.forEach(c=>{
        c.addEventListener('click',function () {
              if (c.firstElementChild.classList.contains('active')) {
                c.firstElementChild.classList.remove('active')
              }
              else{
                c.firstElementChild.classList.add('active')
              }
        })
    })
}
//product-detail image carousel

let imageItems = document.querySelectorAll(".detail-img");
let baseImage = document.querySelector("#main-detail-image");

imageItems.forEach((elem) => {
    elem.addEventListener("click", function () {
        baseImage.src = this.src
    });
});


