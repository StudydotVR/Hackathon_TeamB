/* 泡のスクリプトのお風呂バージョン */
(function(w, d, b) {
	var h = w.innerHeight,
	u = d.documentElement.scrollTop || b.scrollTop,
	e = u - 10,
	z = 9999,
	i = 0,
	p = 0,
	t = new Array(),
	l = new Array(),
	y = new Array(),
	s = new Array(),
	g = new Array(),
	c = new Array(),
	q = d.createElement('div'),
	css = '.bubble{'+
		'position:absolute;'+
		'background:rgba(255,255,255,0.2);'+
		'border-radius:8px;'+
		'box-shadow: 0 0 1px 2px rgba(255,255,225,0.3);'+
		'}'+ 
	'.bubble::after{'+
		'content:"";'+
		'display:block;'+
		'height:4px;'+
		'width:4px;'+
		'border-radius:2px;'+
		'background:rgba(255,255,255,0.4);'+
	'}';
 
	q.innerHTML = '<style>'+ css +'</style>';
	q.id = 'bubbleparticle';
	b.appendChild(q);
	q = d.getElementById('bubbleparticle');
	b.style.overflowX = 'hidden';
 
	/* スクロールとリサイズ時のイベント */
	d.addEventListener('scroll', function() {
		u = d.documentElement.scrollTop || b.scrollTop;
	}, false);
	w.addEventListener('resize', function() {
		u = d.documentElement.scrollTop || b.scrollTop;
		h = w.innerHeight;
	}, false);
 
	/* 泡用の div を100個用意 */
	for (i = 0; i < 100; i++) {
		var m = d.createElement('div');
		m.id = 'awa' + i;
		t[i] = Math.random() * (h + u) + u; /* 泡の発生位置、top */
		l[i] = Math.random() * w.innerWidth; /* 泡の発生位置、left*/
		p = Math.random() * 8 + 6; /* 泡のサイズ */
		m.setAttribute('style', 'z-index:' + (z + i) + ';top:' + t[i] + 'px;width:' + p + 'px;height:' + p + 'px;left:' + l + 'px;');
		m.setAttribute('class', 'bubble');
		q.appendChild(m);
		y[i] = Math.random() * 25 + 0.1; /* ゆらぐ最大値 */
		s[i] = Math.random() * 5 + 3.5; /* 上昇速度最大値 */
		g[i] = d.getElementById('awa' + i);
		c[i] = 0;
	}
 
	/* 泡をアニメーションさせるループ */
	setInterval(function() {
		for (i = 0; i < 100; i++) {
			if (u < t[i]) {
				if (y[i] >= c[i]) {
					l[i] = l[i] + 0.5 + Math.random() * 0.5;
				} else {
					l[i] = l[i] - 0.5 - Math.random() * 0.5;
				}
				if ((y[i] * 2) <= c[i]) {
					c[i] = 0;
				}
			} else {
				t[i] = u + h - 16;
				l[i] = Math.random() * w.innerWidth;
			}
			t[i] = t[i] - s[i];
			g[i].style.top = t[i] + 'px';
			g[i].style.left = l[i] + 'px';
			c[i]++;
		}
	}, 45);
})(window, document, document.body);
