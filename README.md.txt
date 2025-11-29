# AR_Bangun_Ruang

## Cara install pertama kali
1. clone repositroy
```
git clone <link_repository>
```
2. buka projectnya melalui unity hub 
3. import package vuforia dan rebuild package
4. tunggu hingga selesai

## Cara push
1. pastikan di gitignore ada baris
```
/Packages/*.tgz
```
2. tutup project unity dulu
3. ubah _/Packages/manifest.json_
```
"com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-11.4.4.tgz"
```
jadi
```
"com.ptc.vuforia.engine": "11.4.4"
```
4. lalu push aja

## Cara pull
1. setelah pull dari github, tapi sebelum membuka project ubah lagi pada _/Packages/manifest.json_
```
"com.ptc.vuforia.engine": "11.4.4"
```
jadi (sesuaikan sesuai versi milik masing-masing)
```
"com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-11.4.4.tgz"
```