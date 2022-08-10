## Experiments with Hot Chocolate an open-source GraphQL server for .NET


Fetch a read-only view of all movies.

```
query {
  movies {
    id
    title
     actors {
     firstName
     lastName
   }
  }
}
```

Fetch a read-only view of a movie by id.

```
query {
  movieById (id: 2) {
    id
    title
     actors {
     firstName
     lastName
   }
  }
}
```

Add a new movie and return the id.

```
mutation {
	addMovie(movieName: "Forrest Gump" actors: { firstName : "Tom", lastName: "Hanks"}) {
	id
   }
}
```

Subscribe to the movie added event in real time.

```
subscription {
  movieAdded {
    title
    id
    actors {
      firstName
      lastName
    }
  }
}
```