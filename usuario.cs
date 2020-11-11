using System;

class User {
  string _name;
  double _budget;
  
  //CONSTRUTOR SEM EMAIL
  public User (string name) {
    _name = name;
    _budget = 0.0;
  }

  public User () {
    _name = "Anon";
    _budget = 0.0;
  }

  // GETs and SETs
  public string name {
    get { return _name; }
    //set { _name = value; }
  }
  /*
  public string email {
    get { return _email; }
    set { _email = value; }
  }
  */
  public double budget {
    get { return _budget; }
    set { _budget = value; }
  }

}