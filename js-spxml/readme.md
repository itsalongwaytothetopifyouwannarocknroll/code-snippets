# SPXML Javascript snippets

## XQuery

Filter using funciton MatchSome by attributes wich are in OpenDocByID object.

```
MatchSome($elem/attribute,(" + _CRITERIA + "))
```

Example:

```
_RESULT = XQuery("for $elem in compound_programs where MatchSome($elem/role_id,(" + _CRITERIA + ")) return $elem");
```

## Debuging

Print to xhttp.log object serialized to XML (replace _OBJECT)

```
alert(tools.object_to_text(_OBJECT, "xml"));
```

Print to xhttp.log if log enabled

```
LOG_ENABLED = true;
LOG_ENABLED = LOG_ENABLED ? alert('SAMPLE') : false;
```

