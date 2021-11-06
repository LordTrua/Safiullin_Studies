from django import forms
CHOICES = [
    ('Action', 'Action'),
    ('RPG', 'RPG'),
    ('MMO', 'MMO'),
]
class UserForm(forms.Form):
    name = forms.MultipleChoiceField(
        required=False,
        widget=forms.CheckboxSelectMultiple,
        choices=CHOICES,
    )
    