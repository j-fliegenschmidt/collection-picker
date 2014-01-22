Collection Picker
=================

A simple user control and implementation in a dialog that lets users pick an item from a collection. For your prototyping needs.

There is room for improvement here. Right now this only provides a little sugar on top of the basic need. I usually use this when throwing together a quick prototype- direct picking from a collection hasn't made it into a production project of mine yet.

Why don't you make use of generics?
-----------------------------------

Well, I do use them generally, but in this case there are several implementations where one might think generics would have been simpler, and I agree. But WinForms doesn't like them, simple as that. Whipping up the dialog in a generic fashion works, but implementing a generic control type will break your designer (which is kind of obvious, actually; how would it know the parameters?).
