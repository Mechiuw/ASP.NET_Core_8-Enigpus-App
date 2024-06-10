# Library Book Management App

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Running the Application](#running-the-application)
- [Usage](#usage)

## Overview

This project is a console-based Library Book Management Application written in C#. It is designed to help manage books in a library, including adding new books, updating book information, deleting books, and searching for books. This application provides a simple interface to perform these tasks efficiently.

## Features

- **Add New Books**: Add details of new books to the library.
- **Update Book Information**: Modify the details of existing books.
- **Delete Books**: Remove books from the library.
- **Search Books**: Search for books by title, author, or ISBN.
- **List All Books**: Display a list of all books in the library.

## Prerequisites

- .NET Core SDK 8.0
- Visual Studio Code 

- ## Contact

For any questions, suggestions, or feedback, please feel free to contact me:

- **Name**: Matthew Diamonda
- **Email**: [matthewdpk@google.com](mailto:matthewdpk@example.com)
- **GitHub**: [Mechiuw](https://github.com/Mechiuw)

## Usage

Service Layer (novel & magazine) :
### Add Book :
```csharp
 public NovelResponse Create(NovelRequest novelRequest)
    {
        Novel novel = new(
            novelRequest.Id,
            novelRequest.Title,
            novelRequest.Author,
            novelRequest.Year,
            novelRequest.Writer);
        _novelRepo.Add(novel);

        return new NovelResponse(
            novel.Id,
            novel.Title,
            novel.Author,
            novel.Year,
            novel.Writer);
    }

public MagazineResponse MagCreate(MagazineRequest magazineRequest){
        Magazine magazine = new(
            magazineRequest.Id,
            magazineRequest.Title,
            magazineRequest.Author,
            magazineRequest.Year
        );

        _magazineRepo.Add(magazine);
        return new MagazineResponse(
            magazine.Id,
            magazine.Title,
            magazine.Author,
            magazine.Year
        );
    }
```

### Get All Book (Novel & Magazine) :
```csharp
public List<Novel> GetAll()
    {
        return new List<Novel>(_novelRepo);
    }

public List<Magazine> MagGetAll(){
        return new List<Magazine>(_magazineRepo);
    }
```

### Get By Id Book (Novel & Magazine) :
```csharp
public NovelResponse GetById(String Id)
    {
        Novel foundNovel = _novelRepo.FirstOrDefault(x => x.Id == Id);
        if(foundNovel != null){
            return new NovelResponse(
                foundNovel.Id,
                foundNovel.Title,
                foundNovel.Author,
                foundNovel.Year,
                foundNovel.Writer
            );
        } else {
            throw new Exception(String.Format("couldn't find any novel with id : {0}",Id));
        }
    }

public MagazineResponse MagGetById(string Id){
        Magazine foundMagazine = _magazineRepo.FirstOrDefault(x => x.Id == Id);
        if(foundMagazine != null){
            return new MagazineResponse(
                foundMagazine.Id,
                foundMagazine.Title,
                foundMagazine.Author,
                foundMagazine.Year
            );
        } else {
            throw new Exception(String.Format("couldn't find any magazine with id : {0}",Id));
        }
    }
```
 

