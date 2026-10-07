# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt"></a> Class CDOTAClientMsg\_InteractionChannelsRequireHalt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_InteractionChannelsRequireHalt : IMessage<CDOTAClientMsg_InteractionChannelsRequireHalt>, IEquatable<CDOTAClientMsg_InteractionChannelsRequireHalt>, IDeepCloneable<CDOTAClientMsg_InteractionChannelsRequireHalt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_InteractionChannelsRequireHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_InteractionChannelsRequireHalt.md)

#### Implements

IMessage<CDOTAClientMsg\_InteractionChannelsRequireHalt\>, 
[IEquatable<CDOTAClientMsg\_InteractionChannelsRequireHalt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_InteractionChannelsRequireHalt\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_InteractionChannelsRequireHalt\>\(CDOTAClientMsg\_InteractionChannelsRequireHalt, params CDOTAClientMsg\_InteractionChannelsRequireHalt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt__ctor"></a> CDOTAClientMsg\_InteractionChannelsRequireHalt\(\)

```csharp
public CDOTAClientMsg_InteractionChannelsRequireHalt()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_"></a> CDOTAClientMsg\_InteractionChannelsRequireHalt\(CDOTAClientMsg\_InteractionChannelsRequireHalt\)

```csharp
public CDOTAClientMsg_InteractionChannelsRequireHalt(CDOTAClientMsg_InteractionChannelsRequireHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_InteractionChannelsRequireHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_InteractionChannelsRequireHalt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_EnabledFieldNumber"></a> EnabledFieldNumber

```csharp
public const int EnabledFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_HasEnabled"></a> HasEnabled

```csharp
public bool HasEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_InteractionChannelsRequireHalt> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_InteractionChannelsRequireHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_InteractionChannelsRequireHalt.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_ClearEnabled"></a> ClearEnabled\(\)

```csharp
public void ClearEnabled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_InteractionChannelsRequireHalt Clone()
```

#### Returns

 [CDOTAClientMsg\_InteractionChannelsRequireHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_InteractionChannelsRequireHalt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_"></a> Equals\(CDOTAClientMsg\_InteractionChannelsRequireHalt\)

```csharp
public bool Equals(CDOTAClientMsg_InteractionChannelsRequireHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_InteractionChannelsRequireHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_InteractionChannelsRequireHalt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_"></a> MergeFrom\(CDOTAClientMsg\_InteractionChannelsRequireHalt\)

```csharp
public void MergeFrom(CDOTAClientMsg_InteractionChannelsRequireHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_InteractionChannelsRequireHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_InteractionChannelsRequireHalt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_InteractionChannelsRequireHalt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

