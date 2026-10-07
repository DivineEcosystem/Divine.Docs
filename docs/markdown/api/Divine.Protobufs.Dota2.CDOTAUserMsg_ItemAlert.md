# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert"></a> Class CDOTAUserMsg\_ItemAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ItemAlert : IMessage<CDOTAUserMsg_ItemAlert>, IEquatable<CDOTAUserMsg_ItemAlert>, IDeepCloneable<CDOTAUserMsg_ItemAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_ItemAlert\>, 
[IEquatable<CDOTAUserMsg\_ItemAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ItemAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ItemAlert\>\(CDOTAUserMsg\_ItemAlert, params CDOTAUserMsg\_ItemAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert__ctor"></a> CDOTAUserMsg\_ItemAlert\(\)

```csharp
public CDOTAUserMsg_ItemAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_"></a> CDOTAUserMsg\_ItemAlert\(CDOTAUserMsg\_ItemAlert\)

```csharp
public CDOTAUserMsg_ItemAlert(CDOTAUserMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_ItemAlertFieldNumber"></a> ItemAlertFieldNumber

```csharp
public const int ItemAlertFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_ItemAlert"></a> ItemAlert

```csharp
public CDOTAMsg_ItemAlert ItemAlert { get; set; }
```

#### Property Value

 [CDOTAMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ItemAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ItemAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_"></a> Equals\(CDOTAUserMsg\_ItemAlert\)

```csharp
public bool Equals(CDOTAUserMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_"></a> MergeFrom\(CDOTAUserMsg\_ItemAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_ItemAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_ItemAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ItemAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ItemAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

