using System;

class Idea {
  string _title, _type, _description, _author;
  int _votes, _id;
  //int _rank;

  //CCONSTRUCTOR
  public Idea (string title, string type, string description, string name, int id) {
    _title = title;
    _type = type;
    _description = description;
    _author = name;
    _id = id;
  }

  public Idea () {
    _title = "";
    _type = "";
    _description = "";
    _votes = 0;
    //_rank = 0;
  }

  //GETs and SETs
  public string title {
    get { return _title; }
    set { _title = value; }
  }

  public string type {
    get { return _type; }
    set { _type = value; }
  }

  public string description {
    get { return _description; }
    set { _description = value; }
  }
  
  public int votes {
    get { return _votes; }
    set { _votes = value; }
  }
  /*
  public int rank {
    get { return _rank; }
    set { _rank = value; }
  }
  */
  public int id {
    get { return _id; }
    set { _id = value; }
  }

  public string author {
    get { return _author; }
    set { _author = value; }
  }
  
}