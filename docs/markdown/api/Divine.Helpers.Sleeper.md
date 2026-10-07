# <a id="Divine_Helpers_Sleeper"></a> Class Sleeper

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.dll  

```csharp
public sealed class Sleeper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Sleeper](Divine.Helpers.Sleeper.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<Sleeper\>\(Sleeper, params Sleeper\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Helpers_Sleeper__ctor"></a> Sleeper\(\)

```csharp
public Sleeper()
```

### <a id="Divine_Helpers_Sleeper__ctor_System_Single_"></a> Sleeper\(float\)

```csharp
public Sleeper(float sleepMilliseconds)
```

#### Parameters

`sleepMilliseconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Divine_Helpers_Sleeper_IsSleeping"></a> IsSleeping

```csharp
public bool IsSleeping { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Helpers_Sleeper_RemainingSleepTime"></a> RemainingSleepTime

```csharp
public float RemainingSleepTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Helpers_Sleeper_Sleeping"></a> Sleeping

```csharp
[Obsolete("Use IsSleeping")]
public bool Sleeping { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Helpers_Sleeper_ExtendSleep_System_Single_"></a> ExtendSleep\(float\)

```csharp
public void ExtendSleep(float milliseconds)
```

#### Parameters

`milliseconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Helpers_Sleeper_Reset"></a> Reset\(\)

```csharp
public void Reset()
```

### <a id="Divine_Helpers_Sleeper_Sleep_System_Single_"></a> Sleep\(float\)

```csharp
public void Sleep(float milliseconds)
```

#### Parameters

`milliseconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Helpers_Sleeper_SleepUntil_System_Single_"></a> SleepUntil\(float\)

```csharp
public void SleepUntil(float rawGameTime)
```

#### Parameters

`rawGameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Operators

### <a id="Divine_Helpers_Sleeper_op_Implicit_Divine_Helpers_Sleeper__System_Boolean"></a> implicit operator bool\(Sleeper\)

```csharp
public static implicit operator bool(Sleeper sleeper)
```

#### Parameters

`sleeper` [Sleeper](Divine.Helpers.Sleeper.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

