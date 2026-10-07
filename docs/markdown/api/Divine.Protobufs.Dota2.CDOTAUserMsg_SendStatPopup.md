# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup"></a> Class CDOTAUserMsg\_SendStatPopup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SendStatPopup : IMessage<CDOTAUserMsg_SendStatPopup>, IEquatable<CDOTAUserMsg_SendStatPopup>, IDeepCloneable<CDOTAUserMsg_SendStatPopup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendStatPopup.md)

#### Implements

IMessage<CDOTAUserMsg\_SendStatPopup\>, 
[IEquatable<CDOTAUserMsg\_SendStatPopup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SendStatPopup\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SendStatPopup\>\(CDOTAUserMsg\_SendStatPopup, params CDOTAUserMsg\_SendStatPopup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup__ctor"></a> CDOTAUserMsg\_SendStatPopup\(\)

```csharp
public CDOTAUserMsg_SendStatPopup()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_"></a> CDOTAUserMsg\_SendStatPopup\(CDOTAUserMsg\_SendStatPopup\)

```csharp
public CDOTAUserMsg_SendStatPopup(CDOTAUserMsg_SendStatPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendStatPopup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_StatpopupFieldNumber"></a> StatpopupFieldNumber

```csharp
public const int StatpopupFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SendStatPopup> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendStatPopup.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_Statpopup"></a> Statpopup

```csharp
public CDOTAMsg_SendStatPopup Statpopup { get; set; }
```

#### Property Value

 [CDOTAMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAMsg\_SendStatPopup.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SendStatPopup Clone()
```

#### Returns

 [CDOTAUserMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendStatPopup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_"></a> Equals\(CDOTAUserMsg\_SendStatPopup\)

```csharp
public bool Equals(CDOTAUserMsg_SendStatPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendStatPopup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_"></a> MergeFrom\(CDOTAUserMsg\_SendStatPopup\)

```csharp
public void MergeFrom(CDOTAUserMsg_SendStatPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_SendStatPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_SendStatPopup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SendStatPopup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

