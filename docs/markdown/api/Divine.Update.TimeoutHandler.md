# <a id="Divine_Update_TimeoutHandler"></a> Class TimeoutHandler

Namespace: [Divine.Update](Divine.Update.md)  
Assembly: Divine.dll  

```csharp
public class TimeoutHandler : InvokeHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvokeHandler](Divine.Update.InvokeHandler.md) ← 
[TimeoutHandler](Divine.Update.TimeoutHandler.md)

#### Inherited Members

[InvokeHandler.Default](Divine.Update.InvokeHandler.md\#Divine\_Update\_InvokeHandler\_Default), 
[InvokeHandler.Invoke\(Action\)](Divine.Update.InvokeHandler.md\#Divine\_Update\_InvokeHandler\_Invoke\_System\_Action\_), 
[InvokeHandler.Reset\(\)](Divine.Update.InvokeHandler.md\#Divine\_Update\_InvokeHandler\_Reset), 
[InvokeHandler.ToString\(\)](Divine.Update.InvokeHandler.md\#Divine\_Update\_InvokeHandler\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<TimeoutHandler\>\(TimeoutHandler, params TimeoutHandler\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Update_TimeoutHandler__ctor_System_Int32_System_Boolean_"></a> TimeoutHandler\(int, bool\)

```csharp
public TimeoutHandler(int timeout, bool fromNow = false)
```

#### Parameters

`timeout` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`fromNow` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="Divine_Update_TimeoutHandler_HasTimeout"></a> HasTimeout

```csharp
protected bool HasTimeout { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Update_TimeoutHandler_NextUpdate"></a> NextUpdate

```csharp
protected DateTime NextUpdate { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Divine_Update_TimeoutHandler_Timeout"></a> Timeout

```csharp
public int Timeout { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Update_TimeoutHandler_Invoke_System_Action_"></a> Invoke\(Action\)

```csharp
public override bool Invoke(Action callback)
```

#### Parameters

`callback` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Update_TimeoutHandler_Reset"></a> Reset\(\)

```csharp
public override void Reset()
```

### <a id="Divine_Update_TimeoutHandler_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

