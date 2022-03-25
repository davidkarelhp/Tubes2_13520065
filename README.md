# Tubes2_13520065
Tugas Besar 2 IF2211 Strategi Algoritma
Pengaplikasian Algoritma BFS dan DFS dalam Implementasi Folder-Crawling

## Daftar Isi
* [Deskripsi Singkat Program](#deskripsi-singkat-program)
* [Struktur Program](#struktur-program)
* [Requirement Program](#requirement-program)
* [Cara Kompilasi Program](#cara-kompilasi-program)
* [Cara Menjalankan Program](#cara-menjalankan-program)
* [Authors](#authors)
* [Link Demo Program](#link-demo-program)

## Deskripsi Singkat Program

Dalam tugas besar ini, Anda akan diminta untuk membangun sebuah aplikasi GUI sederhana yang dapat memodelkan fitur dari file explorer pada sistem operasi, yang pada tugas ini disebut dengan Folder Crawling. Dengan memanfaatkan algoritma Breadth First Search (BFS) dan Depth First Search (DFS), Anda dapat menelusuri folder-folder yang ada pada direktori untuk mendapatkan direktori yang Anda inginkan. Anda juga diminta untuk memvisualisasikan hasil dari pencarian folder tersebut dalam bentuk pohon.

Langkah awal dalam proses mendesain solusi dari permasalahan ini adalah dengan membagi permasalahan utama, yaitu folder crawling, menjadi beberapa permasalahan kecil sehingga dapat mempermudah pencarian solusi. Permasalahan tersebut dapat dibagi menjadi dua permasalahan utama, yaitu pencarian file menggunakan algoritma breadth-first search dan algoritma depth-first search. Selain itu, ada permasalahan-permasalahan tambahan yang perlu untuk diselesaikan yaitu solusi dari dua permasalahan utama tersebut harus ditampilkan dalam bentuk desktop application.

Setelah membagi permasalahan menjadi dua, yaitu pencarian menggunakan algoritma breadth- first search dan algoritma depth-first search, langkah selanjutnya adalah dengan melakukan pemetaan permasalahan ke dalam elemen-elemen algoritma breadth-first search dan algoritma depth-first search. Setelah melakukan pemetaan elemen-elemen algoritma, dilakukan perancangan algoritma sesuai dengan elemen yang telah dipetakan. Selain itu, kami menambahkan sedikit heuristik pada algoritma dengan cara memeriksa seluruh file terlebih dahulu pada kedalaman sekarang sebelum memeriksa folder.

Dalam menyelesaikan permasalahan tambahan, yaitu menampilkan solusi dari pencarian menggunakan algoritma breadth-first search dan depth-first search, kami menggunakan bantuan WinForms. Selain itu, kami juga menggunakan bantuan pustaka MSAGL dalam menampilkan visusalisasi dari pohon yang telah dibentuk.

## Struktur Program

    .
    │   .gitignore
    │   README.md
    │
    ├───bin
    │   └───Release
    │       │   WinFormsApp1.1.0.0.nupkg
    │       │
    │       └───net6.0-windows
    │               AutomaticGraphLayout.dll
    │               AutomaticGraphLayout.Drawing.dll
    │               Microsoft.Msagl.GraphViewerGdi.dll
    │               Microsoft.Msagl.WpfGraphControl.dll
    │               Tubes2_13520065.exe
    │               WinFormsApp1.deps.json
    │               WinFormsApp1.dll
    │               WinFormsApp1.runtimeconfig.json
    │
    ├───doc
    │       Tubes2_13520065.pdf
    │
    └───src
        │   WinFormsApp1.sln
        │
        └───WinFormsApp1
            │   Form1.cs
            │   Form1.Designer.cs
            │   Form1.resx
            │   Program.cs
            │   WinFormsApp1.csproj
            │   WinFormsApp1.csproj.user
            │
            ├───obj
            │       project.assets.json
            │       project.nuget.cache
            │       WinFormsApp1.csproj.nuget.dgspec.json
            │       WinFormsApp1.csproj.nuget.g.props
            │       WinFormsApp1.csproj.nuget.g.targets
            │
            ├───Properties
            │       Resources.Designer.cs
            │       Resources.resx
            │
            └───Resources
                    icons8-search-folder-40.png

## Requirement Program
    - Windows Operating System
    - .NET
    - Visual Studio 2022
    - MSAGL
    - WPF

## Cara Kompilasi Program
1. Lakukan git clone terhadap repositori ini
2. Buka Solution `WinFormsApp1.sln` dari repositori ini
3. Run program dengan menggunakan tombol Run pada Visual Studio 2022

## Cara Menjalankan Program
1. Buka folder `bin/Release/net6.0-windows` pada folder repositori
2. Jalankan file `Tubes2_13520065.exe`

## Authors

| NIM      | NAMA                        |
|----------|-----------------------------|
| 13520065 | Rayhan Kinan Muhannad       |
| 13520113 | Brianaldo Phandiarta        |
| 13520154 | David Karel Halomoan        |

## Link Demo Program
* [Tugas Besar II IF2211 Strategi Algoritma tahun 2021/2022](https://youtu.be/yXU5yzOTzYQ)