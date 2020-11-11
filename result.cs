using System;

class Result {

  Idea winner = new Idea();

  public void rank (Idea idea) {
    if (idea.votes > winner.votes) {
      winner = idea;
    }
  }

  public double donation (int totalVotes) {
    return (((winner.votes/totalVotes)^2)*30000);
  }

}