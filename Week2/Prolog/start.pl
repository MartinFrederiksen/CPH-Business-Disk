student(martin).

class(martin, mal).
class(martin, dbd).
class(martin, ufo).

student(Name, Class) :-
    student(Name),
    class(Name, X).
