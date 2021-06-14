var Product = {
    IPhone: {
        Detail: {
            productName: 'iPhone 12',
            imgUrl: './img/iphone-12-select-family.jpg'
        },
        Colorstyle: [
            { color: '白色', colorValue: '#f0f0f0', imageUrl: '../img/iphone-12-white-select.png' },
            { color: '黑色', colorValue: '#000000', imageUrl: '../img/iphone-12-black-select.png' },
            { color: '藍色', colorValue: '#004b97', imageUrl: '../img/iphone-12-blue-select.png' },
            { color: '紅色', colorValue: '#990036', imageUrl: '../img/iphone-12-red-select.png' },
        ],
        Storge: [
            { size: '64GB', price: 26900 },
            { size: '128GB', price: 28500 },
            { size: '256GB', price: 32000 },
        ]
    },
    IPad: {
        Detail: {
            productName: 'iPad',
            imgUrl: './img/ipad-2020-hero-landing.jpg'
        },
        Colorstyle: [
            { color: '太空灰色', colorValue: '#6e6969', imageUrl: '../img/ipad-2020-hero-space-wifi-select.png' },
            { color: '銀色', colorValue: '#b9aeae', imageUrl: '../img/ipad-2020-hero-silver-wifi-select.png' },
            { color: '金色', colorValue: '#ceb7a8', imageUrl: '../img/ipad-2020-hero-gold-wifi-select.png' },
        ],
        Storge: [
            { size: '32GB', price: 10900 },
            { size: '128GB', price: 13900 },
        ]
    },
    MacPro: {
        Detail: {
            productName: 'MacPro 13',
            imgUrl: './img/mac-family-compare.jpg'
        },
        Colorstyle: [
            { color: '太空灰色', colorValue: '#6e6969', imageUrl: '../img/macbookpro-13-spacegray.png' },
            { color: '銀色', colorValue: '#b9aeae', imageUrl: '../img/macbookpro-13-silver.png' },
            { color: '金色', colorValue: '#ceb7a8', imageUrl: '../img/macbookpro-13-gold.png' },
        ],
        Storge: [
            { size: '256GB', price: 51300 },
            { size: '512GB', price: 57300 },
            { size: '1TB', price: 63300 },
            { size: '2TB', price: 75300 },
        ]
    }
};