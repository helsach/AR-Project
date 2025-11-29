# 🚀 AR Project - Panduan Instalasi dan Version Control

Panduan ini menjelaskan langkah-langkah untuk menginstal proyek AR untuk pertama kalinya, serta prosedur untuk melakukan *push* dan *pull* ke/dari GitHub, dengan penekanan pada penanganan paket **Vuforia Engine**.

---

## ✅ Cara Install Pertama Kali

Langkah-langkah ini dilakukan saat pertama kali mengunduh dan membuka proyek.

1.  ### **Clone Repository**
    Buka terminal atau Git Bash, lalu *clone* repositori proyek:
    ```bash
    git clone <link_repository>
    ```

2.  ### **Buka Project Lewat Unity Hub**
    * Buka **Unity Hub**.
    * Klik **Open Project**.
    * Pilih folder hasil *clone* repositori.

3.  ### **Import Vuforia Engine 10.18.4**
    * *Import* paket **Vuforia Engine 10.18.4** (Biasanya file `.unitypackage` atau dari file `.tgz` lokal).
    * Tunggu sampai proses *rebuild package* selesai.
    * 

---

## ✅ Cara Push ke GitHub

Prosedur ini dilakukan sebelum *commit* dan *push* untuk memastikan paket Vuforia tidak diunggah langsung ke Git.

1.  ### **Pastikan `.gitignore` Sudah Benar**
    Tambahkan baris berikut ke file `.gitignore` untuk mengabaikan paket lokal `.tgz`:
    ```
    /Packages/*.tgz
    ```

2.  ### **Tutup Project Unity**
    Pastikan aplikasi **Unity Editor** sudah tertutup.

3.  ### **Ubah File `Packages/manifest.json`**
    Ubah referensi paket Vuforia dari jalur file lokal menjadi hanya versi saja.

    **Dari:**
    ```json
    "com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-10.18.4.tgz"
    ```

    **Menjadi:**
    ```json
    "com.ptc.vuforia.engine": "10.18.4"
    ```

4.  ### **Commit & Push**
    Lakukan *commit* perubahan pada file `manifest.json` dan file lainnya, kemudian *push* ke GitHub.
    ```bash
    git commit -m "Deskripsi commit"
    git push origin <nama_branch>
    ```

---

## ✅ Cara Pull dari GitHub

Prosedur ini dilakukan setelah *pull* dari GitHub dan sebelum membuka proyek di Unity.

1.  ### **Pull Repository**
    *Pull* semua perubahan terbaru dari GitHub.
    ```bash
    git pull origin <nama_branch>
    ```

2.  ### **Ubah Kembali `manifest.json`**
    Sebelum membuka proyek di Unity, ubah kembali referensi paket Vuforia di file `Packages/manifest.json` dari versi saja menjadi jalur file lokal `.tgz`.

    **Dari:**
    ```json
    "com.ptc.vuforia.engine": "10.18.4"
    ```

    **Menjadi:**
    ```json
    "com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-10.18.4.tgz"
    ```
    > **Catatan:** Pastikan file `com.ptc.vuforia.engine-10.18.4.tgz` ada di dalam folder `Packages/` Anda.

3.  ### **Buka Project Lewat Unity Hub**
    Buka proyek seperti biasa melalui **Unity Hub**. Unity akan mengenali referensi paket lokal dan memuatnya.

---