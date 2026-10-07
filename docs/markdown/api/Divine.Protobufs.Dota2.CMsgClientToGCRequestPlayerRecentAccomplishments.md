# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments"></a> Class CMsgClientToGCRequestPlayerRecentAccomplishments

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerRecentAccomplishments : IMessage<CMsgClientToGCRequestPlayerRecentAccomplishments>, IEquatable<CMsgClientToGCRequestPlayerRecentAccomplishments>, IDeepCloneable<CMsgClientToGCRequestPlayerRecentAccomplishments>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishments.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerRecentAccomplishments\>, 
[IEquatable<CMsgClientToGCRequestPlayerRecentAccomplishments\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerRecentAccomplishments\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerRecentAccomplishments\>\(CMsgClientToGCRequestPlayerRecentAccomplishments, params CMsgClientToGCRequestPlayerRecentAccomplishments\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments__ctor"></a> CMsgClientToGCRequestPlayerRecentAccomplishments\(\)

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishments()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_"></a> CMsgClientToGCRequestPlayerRecentAccomplishments\(CMsgClientToGCRequestPlayerRecentAccomplishments\)

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishments(CMsgClientToGCRequestPlayerRecentAccomplishments other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishments.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerRecentAccomplishments> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishments.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishments Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_"></a> Equals\(CMsgClientToGCRequestPlayerRecentAccomplishments\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerRecentAccomplishments other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishments.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_"></a> MergeFrom\(CMsgClientToGCRequestPlayerRecentAccomplishments\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerRecentAccomplishments other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishments_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

