// home.js - populate product grids & tab switching
window.initHome = function(){

    const data = {
        "quan-ao": [
            {title:"Áo thể thao nam", brand:"ADIDAS", price:"900.000đ", img:"/images/a1.jpg"},
            {title:"Áo Tank Top", brand:"NIKE", price:"850.000đ", img:"/images/a2.jpg"},
            {title:"Quần short", brand:"PUMA", price:"700.000đ", img:"/images/a3.jpg"},
            {title:"Áo khoác", brand:"ADIDAS", price:"1.200.000đ", img:"/images/a4.jpg"},
            {title:"Hoodie", brand:"NIKE", price:"1.400.000đ", img:"/images/a5.jpg"}
        ],
        "giay": [
            {title:"Giày chạy bộ", brand:"ADIDAS", price:"1.050.000đ", img:"/images/s1.jpg"},
            {title:"Giày training", brand:"NIKE", price:"1.300.000đ", img:"/images/s2.jpg"},
            {title:"Giày đa năng", brand:"PUMA", price:"950.000đ", img:"/images/s3.jpg"},
            {title:"Giày sân", brand:"ADIDAS", price:"1.500.000đ", img:"/images/s4.jpg"},
            {title:"Giày gym", brand:"NIKE", price:"1.100.000đ", img:"/images/s5.jpg"}
        ],
        "dung-cu": [
            {title:"Balo thể thao", brand:"BRAND", price:"450.000đ", img:"/images/d1.jpg"},
            {title:"Bóng đá", brand:"BRAND", price:"600.000đ", img:"/images/d2.jpg"},
            {title:"Thảm tập", brand:"BRAND", price:"350.000đ", img:"/images/d3.jpg"},
            {title:"Găng tập", brand:"BRAND", price:"200.000đ", img:"/images/d4.jpg"},
            {title:"Bình nước", brand:"BRAND", price:"120.000đ", img:"/images/d5.jpg"}
        ],
        "thuc-pham": [
            {title:"Bột protein", brand:"BRAND", price:"650.000đ", img:"/images/t1.jpg"},
            {title:"Thanh năng lượng", brand:"BRAND", price:"45.000đ", img:"/images/t2.jpg"},
            {title:"BCAA", brand:"BRAND", price:"350.000đ", img:"/images/t3.jpg"},
            {title:"Vitamin", brand:"BRAND", price:"220.000đ", img:"/images/t4.jpg"},
            {title:"Sữa phục hồi", brand:"BRAND", price:"480.000đ", img:"/images/t5.jpg"}
        ]
    };

    // helper: build card (with fallback to picsum)
    function buildCard(item){
        const div = document.createElement('div');
        div.className = 'product-card';
        div.innerHTML = `
            <div class="img-wrap">
                <img src="${item.img}" alt="${item.title}" onerror="this.onerror=null;this.src='https://picsum.photos/seed/${encodeURIComponent(item.title)}/600/600'">
            </div>
            <div class="info">
                <div class="brand">${item.brand}</div>
                <div class="title">${item.title}</div>
                <div class="price">${item.price}</div>
            </div>
        `;
        return div;
    }

    // render all grids
    document.querySelectorAll('.product-grid').forEach(g => {
        const cat = g.dataset.cat;
        if (!data[cat]) { g.innerHTML = '<p>Chưa có sản phẩm</p>'; return; }
        g.innerHTML = '';
        data[cat].forEach(item => {
            g.appendChild(buildCard(item));
        });
    });

    // tab switching
    const tabs = document.querySelectorAll('.na-tab');
    tabs.forEach(t => {
        t.addEventListener('click', () => {
            const cat = t.dataset.cat;
            // set active btn
            tabs.forEach(x => x.classList.remove('active'));
            t.classList.add('active');
            // show grid
            document.querySelectorAll('.product-grid').forEach(g => {
                g.classList.toggle('d-none', g.dataset.cat !== cat);
            });
        });
    });

    // make sure initial view shows 'quan-ao'
    document.querySelectorAll('.product-grid').forEach(g => {
        g.classList.toggle('d-none', g.dataset.cat !== 'quan-ao');
    });

    // small hover effect fallback handled by CSS
};

// auto-init on load when layout loads page
document.addEventListener('DOMContentLoaded', function(){
    if (typeof window.initHome === 'function') window.initHome();
});