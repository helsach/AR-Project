AR-Project
✅ Cara Install Pertama Kali
1. Clone repository
git clone <link_repository>

2. Buka project lewat Unity Hub

Buka Unity Hub

Klik Open Project

Pilih folder hasil clone

3. Import Vuforia Engine 10.18.4

Import package Vuforia Engine 10.18.4

Tunggu sampai proses rebuild package selesai

✅ Cara Push ke GitHub
1. Pastikan .gitignore sudah benar

Tambahkan baris berikut:

/Packages/*.tgz

2. Tutup project Unity
3. Ubah file Packages/manifest.json

Dari:

"com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-10.18.4.tgz"


Menjadi:

"com.ptc.vuforia.engine": "10.18.4"

4. Commit & Push

Lakukan commit

Push ke GitHub

✅ Cara Pull dari GitHub
1. Pull repository
2. Sebelum membuka project di Unity, ubah kembali manifest.json

Dari:

"com.ptc.vuforia.engine": "10.18.4"


Menjadi:

"com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-10.18.4.tgz"

3. Buka project lewat Unity Hub