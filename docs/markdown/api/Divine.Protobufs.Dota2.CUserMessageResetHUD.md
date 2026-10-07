# <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD"></a> Class CUserMessageResetHUD

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageResetHUD : IMessage<CUserMessageResetHUD>, IEquatable<CUserMessageResetHUD>, IDeepCloneable<CUserMessageResetHUD>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageResetHUD](Divine.Protobufs.Dota2.CUserMessageResetHUD.md)

#### Implements

IMessage<CUserMessageResetHUD\>, 
[IEquatable<CUserMessageResetHUD\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageResetHUD\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMessageResetHUD\>\(CUserMessageResetHUD, params CUserMessageResetHUD\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD__ctor"></a> CUserMessageResetHUD\(\)

```csharp
public CUserMessageResetHUD()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD__ctor_Divine_Protobufs_Dota2_CUserMessageResetHUD_"></a> CUserMessageResetHUD\(CUserMessageResetHUD\)

```csharp
public CUserMessageResetHUD(CUserMessageResetHUD other)
```

#### Parameters

`other` [CUserMessageResetHUD](Divine.Protobufs.Dota2.CUserMessageResetHUD.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageResetHUD> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageResetHUD](Divine.Protobufs.Dota2.CUserMessageResetHUD.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_Clone"></a> Clone\(\)

```csharp
public CUserMessageResetHUD Clone()
```

#### Returns

 [CUserMessageResetHUD](Divine.Protobufs.Dota2.CUserMessageResetHUD.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_Equals_Divine_Protobufs_Dota2_CUserMessageResetHUD_"></a> Equals\(CUserMessageResetHUD\)

```csharp
public bool Equals(CUserMessageResetHUD other)
```

#### Parameters

`other` [CUserMessageResetHUD](Divine.Protobufs.Dota2.CUserMessageResetHUD.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_MergeFrom_Divine_Protobufs_Dota2_CUserMessageResetHUD_"></a> MergeFrom\(CUserMessageResetHUD\)

```csharp
public void MergeFrom(CUserMessageResetHUD other)
```

#### Parameters

`other` [CUserMessageResetHUD](Divine.Protobufs.Dota2.CUserMessageResetHUD.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageResetHUD_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

