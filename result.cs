using System;

class Result {

  Idea _winner = new Idea();
  double amount;

  public void rank (Idea idea) {
    if (idea.votes > _winner.votes) {
      _winner = idea;
    }
  }

  public double donation (int totalVotes) {
    amount = _winner.votes/totalVotes;
    amount = amount * amount * 30000.0;
    return amount;
  }

  public Idea winner {
    get { return _winner; }
  }

}